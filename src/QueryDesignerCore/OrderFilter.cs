﻿namespace QueryDesignerCore
{
    /// <summary>
    /// Sort by the field.
    /// </summary>
    public class OrderFilter
    {
        /// <summary>
        /// Sort by the field.
        /// </summary>
        public OrderFilter()
        {
            Order = OrderFilterType.Asc;
        }

        /// <summary>
        /// Sort field name.
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        /// Sorting order.
        /// </summary>
        public OrderFilterType Order { get; set; }

        /// <summary>
        /// Additional setting for order filter
        /// </summary>
        public OrderFilterSetting Setting { get; set; } = new OrderFilterSetting();
    }
}