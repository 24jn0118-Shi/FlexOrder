using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexOrderLibrary
{
    public class OrderDetail
    {
        public int goods_id { get; set; }
        public string goods_name { get; set; }
        public int price { get; set; }
        public int quantity { get; set; }
        public bool is_provided { get; set; }

        public int Subtotal
        {
            get { return price * quantity; }
        }
    }
}
