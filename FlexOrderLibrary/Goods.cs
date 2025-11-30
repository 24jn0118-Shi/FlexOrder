using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexOrderLibrary
{
    public class Goods
    {
        public string goods_code { get; set; }
        public int language_no { get; set; }
        public string group_code { get; set; }
        public string goods_name { get; set; }
        public string goods_detail { get; set; }
        public int goods_price { get; set; }
        public string goods_image_filename { get; set; }
        public byte[] goods_image_bytes {  get; set; }
        public bool is_recommend { get; set; }
        public bool is_vegetarian { get; set; }
        public bool is_available { get; set; }
    }
}
