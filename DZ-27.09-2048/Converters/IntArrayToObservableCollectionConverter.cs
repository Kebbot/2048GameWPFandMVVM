using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DZ_27._09_2048.Converters
{
    public class IntArrayToObservableCollectionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is not int[,] intArray)
                return null;

            ObservableCollection<ObservableCollection<string>> observableCollection = new();

            for(int i = 0; i < intArray.GetLength(0); i++)
            {
                ObservableCollection<string> innerCollection = new();
                for (int j = 0; j < intArray.GetLength(1); j++)
                {
                    innerCollection.Add(intArray[i, j] != 0 ? intArray[i,j].ToString() : "");
                }
                observableCollection.Add(innerCollection);
            }
            return observableCollection;
            //throw new NotImplementedException();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
