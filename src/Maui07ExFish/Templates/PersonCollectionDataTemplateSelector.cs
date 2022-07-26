﻿using System;
namespace Maui07ExFish.Templates
{
    public class PersonCollectionDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate PersonTemplate { get; set; }
        public DataTemplate CounterTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is Models.PeopleModel)
                return PersonTemplate;
            else
                return CounterTemplate;
        }
    }
}

