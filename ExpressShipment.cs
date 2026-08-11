//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Session2OOP
//{
//    internal class ExpressShipment : Shipment
//    {
//        private decimal extraFee;

//        public decimal ExtraFee
//        {
//            get { return extraFee; }

//            set
//            {
//                if (value >= 0)
//                    extraFee = value;
//            }
//        }

//        public ExpressShipment(
//            string trackingCode,
//            string description,
//            decimal weight,
//            decimal deliveryFee,
//            DeliveryAddress destination,
//            decimal extraFee)
//            : base(trackingCode, description, weight, deliveryFee, destination)
//        {
//            if (extraFee >= 0)
//                this.extraFee = extraFee;
//            else
//                this.extraFee = 0;
//        }

//        public override decimal EstimatedCost
//        {
//            get
//            {
//                return DeliveryFee + (Weight * 5) + ExtraFee;
//            }
//        }
//    }
//}
