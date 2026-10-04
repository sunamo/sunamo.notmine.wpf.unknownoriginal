namespace CountryComboBox

    public class ConverterCountryToFlag : IValueConverter
    {
        static Type type = typeof(ConverterCountryToFlag);

        public object Convert(object value, Type targetType,
        object parameter, CultureInfo culture)
        {
            var v = value.ToString();
            var l = CountryComboBoxUC.localeHelper.GetLangForCountry2(v);

            //Langs l = (Langs)Enum.Parse(typeof(Langs), lang);

            if (l != null) //l.HasValue)
            {
                Bitmap bmp = null;

                switch (l/*.Value*/)
                {
                    case "cs":
                        bmp = Resources.cz;
                        break;
                    case "en":
                        bmp = Resources.gb;
                        break;
                    default:
                        break;
                }

                if (bmp != null)
                {
                    return ImageSourceHelper.ImageSourceFromBitmap2(bmp);
                }
            }

            ThrowEx.NotImplementedCase(SH.NullToStringOrDefault(l));
            return null;

            //string urImage = AppDomain.CurrentDomain.BaseDirectory + "Images\\Countries\\"+ value.ToString() + ".png";
            //return urImage;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return null;
        }

    }
}
