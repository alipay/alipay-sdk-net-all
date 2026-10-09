using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanCommoninsightQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanCommoninsightQueryModel : AopObject
    {
        /// <summary>
        /// 如果画像属于某商户，这个字段就是pid；如果是公域人群画像，字段不是pid
        /// </summary>
        [XmlElement("owner_pid")]
        public string OwnerPid { get; set; }

        /// <summary>
        /// 画像额外请求参数，用于组装画像唯一键
        /// </summary>
        [XmlArray("param_list")]
        [XmlArrayItem("param_entry")]
        public List<ParamEntry> ParamList { get; set; }

        /// <summary>
        /// 画像日期分区，为空默认查询最新日期
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 画像场景码，唯一定义一组画像包含的特征标签
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
