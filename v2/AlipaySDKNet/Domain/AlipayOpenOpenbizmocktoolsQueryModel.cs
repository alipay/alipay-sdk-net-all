using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenOpenbizmocktoolsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenOpenbizmocktoolsQueryModel : AopObject
    {
        /// <summary>
        /// APPID
        /// </summary>
        [XmlElement("app_number")]
        public string AppNumber { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [XmlElement("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 业务类型
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 查询GroupId关系的维度
        /// </summary>
        [XmlElement("condition")]
        public string Condition { get; set; }

        /// <summary>
        /// 环境
        /// </summary>
        [XmlElement("env")]
        public string Env { get; set; }

        /// <summary>
        /// GROUPID
        /// </summary>
        [XmlElement("group_id")]
        public string GroupId { get; set; }

        /// <summary>
        /// 接口名
        /// </summary>
        [XmlElement("interface_name")]
        public string InterfaceName { get; set; }

        /// <summary>
        /// OID值
        /// </summary>
        [XmlElement("oid")]
        public string Oid { get; set; }

        /// <summary>
        /// 操作类型
        /// </summary>
        [XmlElement("operation_type")]
        public string OperationType { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 接口名
        /// </summary>
        [XmlElement("service")]
        public string Service { get; set; }
    }
}
