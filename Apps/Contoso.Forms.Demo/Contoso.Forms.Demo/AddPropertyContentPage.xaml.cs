﻿using System;

namespace Contoso.Forms.Demo
{
    public partial class AddPropertyContentPage
    {
        public event Action<Property> PropertyAdded;

        public AddPropertyContentPage()
        {
            InitializeComponent();
        }

        void AddProperty(object sender, System.EventArgs e)
        {
            Property addedProperty = new Property(NameCell.Text, ValueCell.Text);
            PropertyAdded.Invoke(addedProperty);
            Navigation.PopModalAsync();
        }

        void Cancel(object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}