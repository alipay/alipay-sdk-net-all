using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayDataDataserviceAdDatasetSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDataDataserviceAdDatasetSyncModel : AopObject
    {
        /// <summary>
        /// 灯火平台提供给外部系统的访问token
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 数据集外部标志，不允许重复
        /// </summary>
        [XmlElement("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 数据集外部名称
        /// </summary>
        [XmlElement("data_name")]
        public string DataName { get; set; }

        /// <summary>
        /// 数据源类型类型: LOCAL_MEMBER-本地生活会员数据 LOCAL_COUPON-本地生活优惠券数据 LOCAL_TRANSACTION-本地生活订单数据
        /// </summary>
        [XmlElement("data_src_type")]
        public string DataSrcType { get; set; }

        /// <summary>
        /// 数据所属增量同步odps表名
        /// </summary>
        [XmlElement("data_table_name")]
        public string DataTableName { get; set; }

        /// <summary>
        /// 数据类型：CONVERSION_DATA-转化数据
        /// </summary>
        [XmlElement("data_type")]
        public string DataType { get; set; }

        /// <summary>
        /// 商户id
        /// </summary>
        [XmlElement("principal_id")]
        public string PrincipalId { get; set; }

        /// <summary>
        /// 商户在支付宝灯火pb侧的唯一标志
        /// </summary>
        [XmlElement("principal_tag")]
        public string PrincipalTag { get; set; }

        /// <summary>
        /// 状态: ENABLE-有效; DISABLE-失效
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 用户唯一标志类型: PID-支付宝pid
        /// </summary>
        [XmlElement("user_unique_type")]
        public string UserUniqueType { get; set; }
    }
}
