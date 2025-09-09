using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaCreditEpSceneAccountBatchsendModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaCreditEpSceneAccountBatchsendModel : AopObject
    {
        /// <summary>
        /// 平台合作方实力标场景码，用于标识批量通知来源
        /// </summary>
        [XmlElement("label_scene_code")]
        public string LabelSceneCode { get; set; }

        /// <summary>
        /// list中每一项同步一个商户的相关信息
        /// </summary>
        [XmlArray("sync_list")]
        [XmlArrayItem("string")]
        public List<string> SyncList { get; set; }
    }
}
