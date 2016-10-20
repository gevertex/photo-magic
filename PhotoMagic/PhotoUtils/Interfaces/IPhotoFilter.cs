using System;
using System.IO;
namespace PhotoUtils
{
    public delegate void PhotoProcessingFinished(Stream outputPhoto);

    public interface IPhotoFilter
    {
        bool ProcessPhoto(Stream inputPhoto, PhotoProcessingFinished callback);
    }
}
