using System;

using R5T.T0142;
using R5T.T0172;


namespace R5T.T0201
{
    /// <summary>
    /// Creation output for a library solution set including:
    /// 1) A library project.
    /// 2) A library solution.
    /// 3) A construction project.
    /// 4) A construction solution.
    /// </summary>
    [DataTypeMarker]
    public class LibraryWithConstructionCreationOutput :
        IHasLibraryProjectFilePath,
        IHasConstructionProjectFilePath,
        IHasLibrarySolutionFilePath,
        IHasConstructionSolutionFilePath
    {
        public ISolutionFilePath ConstructionSolutionFilePath { get; set; }
        public ISolutionFilePath LibrarySolutionFilePath { get; set; }

        public IProjectFilePath ConstructionProjectFilePath { get; set; }
        public IProjectFilePath LibraryProjectFilePath { get; set; }
    }
}
