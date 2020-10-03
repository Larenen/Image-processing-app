using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;

namespace APO_Czerniawski
{

    //Source : http://yy-programer.blogspot.com/2012/11/emgucv-image-process-transforming_29.html

    class WatershedSegmenter
    {
        private Image<Gray, Int32> _Markers;

        /// <summary>
        /// Set the maker image
        /// </summary>
        /// <param name="makers">the maker image</param>
        public void SetMakers(Image<Gray, Byte> markers)
        {
            //Convert to image of Int32
            this._Markers = markers.Convert<Gray, Int32>();
        }

        /// <summary>
        /// The idea is to mark some pixels of the image that are known
        /// to certainly belong to a given region. From this initial
        /// labeling, the watershed algorithm will determine the regions
        /// to which the other pixels belong.
        /// </summary>
        /// <param name="image">source image</param>
        /// <returns>labeling image</returns>
        public Image<Gray, Int32> Process(Image<Bgr,Byte> image)
        {
            //Apply watershed
            CvInvoke.Watershed(image, this._Markers);
            return this._Markers;
        }

        /// <summary>
        /// Return watershed in the form an image
        /// </summary>
        /// <returns>watershed image</returns>
        public Image<Gray, Byte> GetWatersheds()
        {
            Image<Gray, Byte> watersheds = this._Markers.Convert<Gray, Byte>();
            watersheds._ThresholdBinary(new Gray(1), new Gray(255));
            return watersheds;
        }
    }
}
