using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayContentLifeaccountStatusSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayContentLifeaccountStatusSyncModel : AopObject
    {
        /// <summary>
        /// 账号最新状态，当前仅支持注销
        /// </summary>
        [XmlElement("account_status")]
        public string AccountStatus { get; set; }

        /// <summary>
        /// 加密后的好大夫id，与public id一起指定一个操作用户
        /// </summary>
        [XmlElement("hdf_id_encrypted")]
        public string HdfIdEncrypted { get; set; }

        /// <summary>
        /// 用于指定更新的内容号id
        /// </summary>
        [XmlElement("public_id")]
        public string PublicId { get; set; }
    }
}
