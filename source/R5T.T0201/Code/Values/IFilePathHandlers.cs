using System;
using System.Threading.Tasks;

using R5T.T0131;
using R5T.T0172;


namespace R5T.T0201
{
    [ValuesMarker]
    public partial interface IFilePathHandlers : IValuesMarker
    {
        public Func<IProjectFilePath, Task> Set_ConstructionProjectFilePath(
            IHasConstructionProjectFilePath hasConstructionProjectFilePath)
        {
            return projectFilePath =>
            {
                hasConstructionProjectFilePath.ConstructionProjectFilePath = projectFilePath;

                return Task.CompletedTask;
            };
        }

        public Func<IProjectFilePath, Task> Set_LibraryProjectFilePath(
            IHasLibraryProjectFilePath hasLibraryProjectFilePath)
        {
            return projectFilePath =>
            {
                hasLibraryProjectFilePath.LibraryProjectFilePath = projectFilePath;

                return Task.CompletedTask;
            };
        }
    }
}
