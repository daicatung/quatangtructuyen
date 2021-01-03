using System;

namespace DTO
{
    class Vendor_DTO
    {
        private int vendorID;
        private String vendorName;
        private bool vendorState;
        public int VendorID { get => vendorID; set => vendorID = value; }
        public string VendorName { get => vendorName; set => vendorName = value; }
        public bool VendorState { get => vendorState; set => vendorState = value; }
    }
}
