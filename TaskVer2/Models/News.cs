using System;

namespace TaskVer2.Models
{
    public class News           //этот клас будет представлять статьи  из лент
    {
        public int NewsID { get; set; }                 //ключ
        public int ChanelID { get; set;}// ID канала с которого пришла новость
        public int CategoryID { get; set; }
        public string title { get; set; }              // перечислены все основные элементы
        public string link { get; set; }                //практика показывает что некоторых может и не быть
        public string Description { get; set; }
        public DateTime pubDate { get; set; }               
        public string category { get; set; }            // вчастности категория присутствует не во всех лентах, ну или не во всех новостях в общем бывает NULL


       
    }
}