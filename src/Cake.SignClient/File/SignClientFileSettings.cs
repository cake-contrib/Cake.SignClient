namespace Cake.SignClient
{
    /// <summary>
    /// Settings for SignClient Sign command.
    /// </summary>
    public sealed class SignClientFileSettings : AutoToolSettings
    {
        /// <summary>
        /// Full path to config json file
        /// </summary>
        public bool Config { get; set; }
        /// <summary>
        /// Full path to input file
        /// </summary>
        public bool Input { get; set; }
        /// <summary>
        /// Full path to output file. May be same
        ///   as input to overwrite. Defaults to
        ///   input file if ommited
        /// </summary>
        public bool Output { get; set; }
        /// <summary>
        /// Hash mode: either dual or Sha256.
        ///   Default is dual, to sign with both
        ///   Sha-1 and Sha-256 for files that
        ///   support it. For files that don't
        ///   support dual, Sha-256 is used
        /// </summary>
        public bool Hashmode { get; set; }
        /// <summary>
        /// Client Secret
        /// </summary>
        public bool Secret { get; set; }
        /// <summary>
        /// Name of project for tracking
        /// </summary>
        public bool Name { get; set; }
        /// <summary>
        /// Description
        /// </summary>
        public bool Description { get; set; }
        /// <summary>
        /// Description Url
        /// </summary>
        public bool DescriptionUrl { get; set; }
    }
}
