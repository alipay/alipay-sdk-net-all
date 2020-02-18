using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppCommunityDataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppCommunityDataSyncModel : AopObject
    {
        /// <summary>
        /// 操作类型.PUT:新增或覆盖,REMOVE:删除
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// 上传数据批次号
        /// </summary>
        [XmlElement("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 用于标识数据所属数据类目
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 上传数据列表
        /// </summary>
        [XmlArray("data_list")]
        [XmlArrayItem("biz_data")]
        public List<BizData> DataList { get; set; }

        /// <summary>
        /// 社区素材内容数据类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
