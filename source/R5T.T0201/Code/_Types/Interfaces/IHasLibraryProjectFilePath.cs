using System;

using R5T.T0142;
using R5T.T0172;


namespace R5T.T0201
{
    [DataTypeMarker]
    public interface IHasLibraryProjectFilePath
    {
        IProjectFilePath LibraryProjectFilePath { get; set; }
    }
}
