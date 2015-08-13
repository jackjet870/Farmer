using System;
namespace Farmer.Core.Domain
{
    /// <summary>
    /// ��������
    /// </summary>
    public partial class ReturnRequest : BaseEntity
    {
        /// <summary>
        /// Gets or sets the store identifier
        /// </summary>
        public Guid StoreId { get; set; }

        /// <summary>
        /// Gets or sets the order item identifier
        /// </summary>
        public Guid OrderItemId { get; set; }

        /// <summary>
        /// Gets or sets the customer identifier
        /// </summary>
        public Guid CustomerId { get; set; }

        /// <summary>
        /// Gets or sets the quantity
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the reason to return
        /// </summary>
        public string ReasonForReturn { get; set; }

        /// <summary>
        /// Gets or sets the requested action
        /// </summary>
        public string RequestedAction { get; set; }

        /// <summary>
        /// Gets or sets the customer comments
        /// </summary>
        public string CustomerComments { get; set; }

        /// <summary>
        /// Gets or sets the staff notes
        /// </summary>
        public string StaffNotes { get; set; }

        /// <summary>
        /// Gets or sets the return status identifier
        /// </summary>
        public int ReturnRequestStatusId { get; set; }
        
       
        /// <summary>
        /// Gets or sets the date and time of entity update
        /// </summary>
        public DateTime UpdatedOn { get; set; }
        
        /// <summary>
        /// Gets or sets the return status
        /// </summary>
        public ReturnRequestStatus ReturnRequestStatus
        {
            get
            {
                return (ReturnRequestStatus)this.ReturnRequestStatusId;
            }
            set
            {
                this.ReturnRequestStatusId = (int)value;
            }
        }

        /// <summary>
        /// Gets or sets the customer
        /// </summary>
        public virtual Customer Customer { get; set; }
    }
}
