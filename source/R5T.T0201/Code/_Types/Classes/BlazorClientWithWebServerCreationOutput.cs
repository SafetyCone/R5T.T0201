using System;

using R5T.T0142;
using R5T.T0172;


namespace R5T.T0201
{
    [DataTypeMarker]
    public class BlazorClientWithWebServerCreationOutput :
        IHasBlazorClientProjectFilePath,
        IHasWebServerProjectFilePath,
        IHasSolutionFilePath
    {
        public IProjectFilePath BlazorClientProjectFilePath { get; set; }
        public IProjectFilePath WebServerProjectFilePath { get; set; }

        public ISolutionFilePath SolutionFilePath { get; set; }
    }
}
