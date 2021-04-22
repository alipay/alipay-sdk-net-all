using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SettleExtraParams Data Structure.
    /// </summary>
    [Serializable]
    public class SettleExtraParams : AopObject
    {
        /// <summary>
        /// quit_type为USER_CANCEL_QUIT或者SETTLE_APPLY_QUIT
        /// </summary>
        [XmlElement("quit_type")]
        public string QuitType { get; set; }
    }
}
