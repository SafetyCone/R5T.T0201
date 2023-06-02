using System;


namespace R5T.T0201
{
    public class FilePathHandlers : IFilePathHandlers
    {
        #region Infrastructure

        public static IFilePathHandlers Instance { get; } = new FilePathHandlers();


        private FilePathHandlers()
        {
        }

        #endregion
    }
}
