namespace Entities
{
    /// <summary>
    ///     Implement an interface to give properties to this class
    /// </summary>
    public class Address : Interfaces.IAddress
    {
        private string addressLine1;
        private string addressLine2;
        private string addressLine3;
        private string addressLine4;

        public string AddressLine1
        {
            get
            {
                return addressLine1;
            }

            set
            {
                addressLine1 = value;
            }
        }

        public string AddressLine2
        {
            get
            {
                return addressLine2;
            }

            set
            {
                addressLine2 = value;
            }
        }

        public string AddressLine3
        {
            get
            {
                return addressLine3;
            }

            set
            {
                addressLine3 = value;
            }
        }

        public string AddressLine4
        {
            get
            {
                return addressLine4;
            }

            set
            {
                addressLine4 = value;
            }
        }
    }
}