using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditSupplychainWfDataauthtokenSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSupplychainWfDataauthtokenSyncModel : AopObject
    {
        /// <summary>
        /// 发送时间
        /// </summary>
        [XmlElement("change_date")]
        public long ChangeDate { get; set; }

        /// <summary>
        /// 状态 DATA_COLLECTION_START 采集开始 DATA_COLLECTION_CLOSED 采集关闭
        /// </summary>
        [XmlElement("collection_status")]
        public string CollectionStatus { get; set; }

        /// <summary>
        /// ["finance", "seller", "order"] 需要判断list里面是否有finance的数据即可，状态可以直接取collectionstatus。
        /// </summary>
        [XmlArray("data_collection_info_ids")]
        [XmlArrayItem("string")]
        public List<string> DataCollectionInfoIds { get; set; }

        /// <summary>
        /// 平台类型 如果亚马逊
        /// </summary>
        [XmlElement("platform_type")]
        public string PlatformType { get; set; }

        /// <summary>
        /// 请求幂等ID
        /// </summary>
        [XmlElement("requestid")]
        public string Requestid { get; set; }

        /// <summary>
        /// WF的卖家ID（亚马逊商家）
        /// </summary>
        [XmlElement("sellerid")]
        public string Sellerid { get; set; }

        /// <summary>
        /// WF站点名称
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点用户ID
        /// </summary>
        [XmlElement("siteuserid")]
        public string Siteuserid { get; set; }

        /// <summary>
        /// 停止原因 store binding change 店铺换绑 seller token invalid Token失效 store invalid 店铺解绑 store exception 店铺异常
        /// </summary>
        [XmlElement("stopped_reason")]
        public string StoppedReason { get; set; }
    }
}
