﻿using System;

namespace DTO
{
    class Category_DTO
    {
        private int categoryID;
        private String categoryName;
        private bool categoryState;

        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public bool CategoryState { get => categoryState; set => categoryState = value; }
    }
}
