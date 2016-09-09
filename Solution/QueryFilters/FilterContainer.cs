﻿using System.Collections.Generic;

namespace QueryFilters
{
    /// <summary>
    /// Container for filters.
    /// </summary>
    public class FilterContainer
    {
        /// <summary>
        /// Where filters.
        /// </summary>
        public TreeFilter Where { get; set; }

        /// <summary>
        /// Order filters.
        /// </summary>
        public List<OrderFilter> OrderBy { get; set; }

        /// <summary>
        /// Skip number of elements.
        /// </summary>
        public int Skip { get; set; }

        /// <summary>
        /// Take number of elements.
        /// </summary>
        public int Take { get; set; } = -1;
    }
}
