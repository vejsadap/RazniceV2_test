using System;
using System.Web;
using System.Xml;
using System.Collections.Specialized;


namespace Raznice.Globalni
{
	/// <summary>
	/// T��da obsahuje v�eobecn� parametry webov� aplikace na��tan� z XML souboru Parametry.xml
	/// Aby bylo doc�leno co mo�n� nejvy��� aktu�lnosti, zji��uje se p�i ka�d�m po�adavku
	/// na hodnotu parametru aktu�lnost dr�en�ch dat (zji�t�n� data souboru). 
	/// </summary>
	public class Parametry
	{
		#region Ve�ejn� statick� vlastnosti


        /// <summary>
        /// jmeno aplikace
        /// </summary>
        public static string aplikace
        {
            get
            {
                return DejHodnotuParametru("aplikace");
            }
        }

        /// <summary>
        /// z jakeho pole ae pouzije konstrukce pro tisk stitku
        /// </summary>

        public static bool tisk_z_pole_prijmeni
        {
            get
            {
                return (Int32.Parse(DejHodnotuParametru("tisk_z_pole_prijmeni")) == 1 ? true : false) ;
            }
        }
        #endregion


        #region Neve�ejn� k�d
        #region Vlastnosti
        /// <summary>
		/// Ur�uje relativn� cestu k XML souboru s parametry
		/// </summary>
        private const string PARAMETRY_XML_RELATIVNI_CESTA = "ParametryAplikace.xml";
		/// <summary>
		/// Uchov�v� seznam parametr� na�ten� z XML dokumentu
		/// </summary>
		private static HybridDictionary parametr;
		/// <summary>
		/// Uchov�v� datum modifikace naposledy na�ten�ho XML souboru 
		/// </summary>
		private static DateTime modifikovano;
		/// <summary>
		/// Uchov�v� automaticky generovanou absolutn� cestu k XML souboru s parametry
		/// </summary>
		private static string absolutniCestaXmlDokumentu;
		#endregion

		#region Konstruktory
		/// <summary>
		/// Statick� konstruktor, kter� se vol� automaticky p�i prvn�m po�adavku
		/// na jakoukoli statickou vlastnost t��dy.
		/// </summary>
		static Parametry()
		{
			// P�ev�d�m relativn� cestu ke XML dokumentu danou konstantou PARAMETRY_XML_RELATIVNI_CESTA
			// na cestu absolutni
			Parametry.absolutniCestaXmlDokumentu = 
				Globalni.Nastroje.DejCestuAplikace() + PARAMETRY_XML_RELATIVNI_CESTA;
//            Parametry.absolutniCestaXmlDokumentu =
//                HttpContext.Current.Request.MapPath(PARAMETRY_XML_RELATIVNI_CESTA);

			// Vytv���m nov� seznam parametr�
			Parametry.parametr = new HybridDictionary();
			// Nastavuji datum posledn� modifikace parametr�
			Parametry.modifikovano = DateTime.MinValue;

			// Prov�d�m aktualizaci parametr�
			Aktualizuj();
		}
		#endregion

		#region Metody
		/// <summary>
		/// Vrac� hodnotu po�adovan�ho parametru.
		/// </summary>
		/// <param name="nazevParametru">N�zev po�adovan�ho parametru</param>
		/// <returns>�et�zec s hodnotou parametru</returns>
		private static string DejHodnotuParametru(string nazevParametru)
		{
			// Provedu aktualizaci parametr�
			// V p��pad�, �e se uk�e, �e t�m doch�z� k v�razn�mu zpomalen� aplikace,
			// lze automatickou aktualizaci vypnout zakomentov�n�m n�sleduj�c�ho ��adku.
			// T�m bude k aktualizaci doch�zet jen p�i inicializaci t�to t��dy (v konstruktoru)
			// nebo v p��pad� zavol�n� statick� metody Aktualizuj();
			Parametry.Aktualizuj();
			// Zjist�m zda seznam parametr� obsahuje po�adovan� parametr. Pakli�e ano,
			// vrac�m jeho hodnotu. Pakli�e ne, vr�t�m pr�zdn� �et�zec.
			return Parametry.parametr.Contains(nazevParametru) ?
				Parametry.parametr[nazevParametru].ToString() : String.Empty;
		}

		/// <summary>
		/// Aktualizuje seznam parametr�
		/// </summary>
		public static void Aktualizuj()
		{
			// Uzamyk�m parametry proti zm�n�m v jin�m vl�knu
			lock(Parametry.parametr)
			{
				// Na��t�m posledn� datum zm�ny parametrick�ho XML souboru
				DateTime zapsano = new System.IO.FileInfo(Parametry.absolutniCestaXmlDokumentu).LastWriteTime;
				// Zjis�uji zda do�lo od posledn� aktualizace ke zm�n� data - existuje nov�j�� verze
				if (zapsano > Parametry.modifikovano)
				{
					// Na�tu novou verzi parametr� a pozna��m si datum a �as zm�ny
					Parametry.Nacti();
					Parametry.modifikovano = zapsano;
				}
			}
		}

		/// <summary>
		/// Na��t� parametry z XML souboru
		/// </summary>
		private static void Nacti() 
		{
			// Vypraz�uji seznam parametr�
			Parametry.parametr.Clear();

			// Na��t�m XML dokument obsahuj�c� seznam parametr�
			XmlDocument xmlDokument = new XmlDocument();
			xmlDokument.Load(absolutniCestaXmlDokumentu);
			
			// Na��t�m elementy se jm�nem "parametr"
			XmlNodeList parametry = xmlDokument.GetElementsByTagName("parametr");
			foreach(XmlNode par in parametry)
			{
				// P�id�v�m jednotliv� parametry do seznamu parametr�
				Parametry.parametr.Add(
					par.Attributes["nazev"].Value,
					par.Attributes["hodnota"].Value);
			}
		}
		#endregion
		#endregion
	}
}
