using System;
using System.Collections.Generic;

namespace Infinity.Data
{
    public partial class Orders
    {
        public Orders()
        {
            InverseReference = new HashSet<Orders>();
            OrderDetails = new HashSet<OrderDetails>();
            Transactions = new HashSet<Transactions>();
        }

        public long Id { get; set; }
        public long? ReferenceId { get; set; }
        public long? PromotionId { get; set; }
        public string CustomerId { get; set; }
        public long? PaymentProviderId { get; set; }
        public long ShippingMethodId { get; set; }
        public long? WarehouseId { get; set; }
        public string PickupAddress { get; set; }
        public string PickupProvince { get; set; }
        public string PickupDistrict { get; set; }
        public string PickupCommune { get; set; }
        public string PickupPhone { get; set; }
        public string PickupTs { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerName { get; set; }
        public string CustomerProvince { get; set; }
        public string CustomerDistrict { get; set; }
        public string CustomerCommune { get; set; }
        public string CustomerAddress { get; set; }
        public string DeliveryTs { get; set; }
        public byte? ShippingConfig { get; set; }
        public byte? ShippingPayer { get; set; }
        public byte? ShippingBarter { get; set; }
        public byte ShippingStatus { get; set; }
        public byte ShippingStatusName { get; set; }
        public long? ShippingFee { get; set; }
        public long? ShippingInsuranceFee { get; set; }
        public long TotalValue { get; set; }
        public long? PromotionValue { get; set; }
        public long ActuallyValue { get; set; }
        public string Note { get; set; }
        public byte Status { get; set; }
        public DateTime CreatedTs { get; set; }
        public DateTime? LastModifiedTs { get; set; }
        public long CreatedBy { get; set; }
        public long? LastModifiedBy { get; set; }

        public virtual AspNetUsers Customer { get; set; }
        public virtual PaymentProviders PaymentProvider { get; set; }
        public virtual Orders Reference { get; set; }
        public virtual ShippingMethods ShippingMethod { get; set; }
        public virtual ICollection<Orders> InverseReference { get; set; }
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }
    }
}
