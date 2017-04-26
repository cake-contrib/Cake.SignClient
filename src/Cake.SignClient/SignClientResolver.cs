using Cake.Core;
using Cake.Core.IO;
using System;

namespace Cake.SignClient
{
    /// <summary>
    /// SignClient resolver. SignClient should be located alongside the addin.
    /// </summary>
    internal static class SignClientResolver
    {
        public static FilePath GetSignClientPath(IFileSystem fileSystem, ICakeEnvironment environment)
        {
            if (fileSystem == null)
            {
                throw new ArgumentNullException("fileSystem");
            }

            if (environment == null)
            {
                throw new ArgumentNullException("environment");
            }

            var location = typeof(SignClientResolver).Assembly.Location;
            var dir = new DirectoryPath(System.IO.Path.GetDirectoryName(location));
            var filePath = dir.CombineWithFilePath("SignClient.exe");
            return fileSystem.GetFile(filePath).Exists ? filePath : null;
        }
    }
}
