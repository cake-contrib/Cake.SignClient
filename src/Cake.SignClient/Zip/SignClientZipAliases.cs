using Cake.Core;
using Cake.Core.Annotations;
using System;

namespace Cake.SignClient
{
    /// <summary>
    /// Contains functionality for working with SignClient.
    /// </summary>
    [CakeAliasCategory("Signing")]
    public static partial class SignClientAliases
    {
        /// <summary>
        /// Invokes zip with array of from arguments.
        /// </summary>
        /// <param name="context">Cake context</param>
        /// <param name="settings">The file settings.</param>
        [CakeMethodAlias]
        public static void SignClientZip(this ICakeContext context, SignClientSignSettings settings)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            if (settings == null)
            {
                throw new ArgumentNullException("settings");
            }

            var runner = new SignClientRunner<SignClientSignSettings >(context.FileSystem, context.Environment, context.ProcessRunner, context.Tools);
            runner.Run("zip", settings, new string[0]);
        }
    }
}
