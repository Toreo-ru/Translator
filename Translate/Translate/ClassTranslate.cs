using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YandexLinguistics.NET;
using System.Xml.Serialization;
using System.IO;

namespace Translate
{
    public class ClassTranslate
    {
       
        private static Lang langDetect(string inputText, string trKey)
        {
            return (new YandexLinguistics.NET.Translator(trKey)).DetectLang(inputText);
        }

        public static string Translator(string wordTranslate, string inputLang, string outputLang)
        {
            string trKey = File.ReadAllText("APIKey.txt", Encoding.Default);

            LangPair langPair = new LangPair();
            if (inputLang.Equals("Default"))
            {
                langPair.InputLang = langDetect(wordTranslate, trKey);
            }
            else
            {
                langPair.InputLang = selector(inputLang);
            }
            langPair.OutputLang = selector(outputLang);
            return (new YandexLinguistics.NET.Translator(trKey)).Translate(wordTranslate, langPair).Text;
        }

        private static Lang selector(string language)
        {
            switch (language)
            {
                case "Азербайджанский":

                    return Lang.Az;

                case "Албанский":

                    return Lang.Sq;

                case "Английский":

                    return Lang.En;
                    
                case "Армянский":

                    return Lang.Hy;

                case "Белорусский":

                    return Lang.Be;

                case "Болгарский":

                    return Lang.Bg;

                case "Венгерский":

                    return Lang.Hu;

                    

                case "Греческий":

                    return Lang.El;

                    

                case "Датский":

                    return Lang.Da;

                    

                case "Испанский":

                    return Lang.Es;

                    
                case "Итальянский":

                    return Lang.It;

                    

                case "Каталанский":

                    return Lang.Ca;

                    

                case "Латышский":

                    return Lang.Lv;

                    
                case "Литовский":

                    return Lang.Lt;

                    
                case "Македонский":

                    return Lang.Mk;

                    

                case "Немецкий":

                    return Lang.De;

                    
                case "Норвежский":

                    return Lang.No;

                    

                case "Польский":

                    return Lang.Pl;

                    
                case "Португальский":

                    return Lang.Pt;

                    
                case "Румынский":

                    return Lang.Ro;

                    
                case "Русский":

                    return Lang.Ru;

                    
                case "Сербский":

                    return Lang.Sr;

                    

                case "Словацкий":

                    return Lang.Sk;

                    
                case "Словенский":

                    return Lang.Sl;

                    

                case "Турецкий":

                    return Lang.Tr;

                    

                case "Украинский":

                    return Lang.Uk;

                    

                case "Финский":

                    return Lang.Fi;

                    
                case "Французский":

                    return Lang.Fr;

                    
                case "Хорватский":

                    return Lang.Hr;

                    

                case "Чешский":

                    return Lang.Cs;

                    
                case "Шведский":

                    return Lang.Sv;

                    

                case "Эстонский":

                    return Lang.Et;

                    

            }
            return Lang.En;
        }
    }
}
