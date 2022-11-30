using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace ROIStaffApp
{
        [ContentProperty(nameof(source))]
        public class ImageResourceExtension : IMarkupExtension
        {
            public string source { get; set; }

            public object ProvideValue(IServiceProvider serviceProvider)
            {
                if (source == null)
                {
                    return null;
                }

                var imageSource = ImageSource.FromResource(source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);
                return imageSource;
            }
        }
}
