using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMedicalYpzConfigSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMedicalYpzConfigSyncModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("bianque_config_item")]
        public List<BianqueConfigItem> DataList { get; set; }
    }
}
