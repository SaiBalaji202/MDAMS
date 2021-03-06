﻿namespace MDAMS
{
    public class Receipt
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Gst { get; set; }
        public string Total => string.Format(@"{0}", (Price + ((Price * Gst) / 100)) * Quantity);
    }
}
