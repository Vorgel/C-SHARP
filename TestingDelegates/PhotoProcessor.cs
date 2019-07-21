namespace TestingDelegates
{
    class PhotoProcessor
    {
        public delegate void PhotoFiltersHandler(Photo photo);
        public void Process(string path, PhotoFiltersHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);

            photo.Save();
        }
    }
}