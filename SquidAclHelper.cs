using System;
using System.IO;

using Craswell.Squid.Helper;
using log4net;

namespace Craswell.Squid.AclHelper
{
    /// <summary>
    /// An ACL helper for Squid.
    /// </summary>
    public class SquidAclHelper : SquidHelper
    {
        /// <summary>
        /// The squid ok message.
        /// </summary>
        public const string SquidOkMessage = "{0}OK";

        /// <summary>
        /// Initializes a new instance of the <see cref="Craswell.Squid.AclHelper.SquidAclHelper"/> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public SquidAclHelper(
            ILog logger)
            : base(logger)
        {
        }

        /// <summary>
        /// Determines the result for the input passed in from Squid.
        /// </summary>
        /// <param name="squidInput">The input.</param>
        /// <returns>The result.</returns>
        protected override string GetResult(SquidInput squidInput)
        {
            string channel = squidInput.ChannelId.HasValue
                ? string.Format("{0} ", squidInput.ChannelId.Value)
                : string.Empty;

            var resultString = string.Format(
                SquidOkMessage,
                channel);

            return resultString;
        }
    }
}
