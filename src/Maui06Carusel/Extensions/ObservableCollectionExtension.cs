﻿using System;
using System.Collections.ObjectModel;

namespace Maui06Carusel.Extensions
{
	public static class ObservableCollectionExtension
	{
        public static void AddRange<T>(this ObservableCollection<T> coll, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                coll.Add(item);
            }
        }
    }
}

