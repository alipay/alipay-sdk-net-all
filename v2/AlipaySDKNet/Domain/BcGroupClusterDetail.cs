using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BcGroupClusterDetail Data Structure.
    /// </summary>
    [Serializable]
    public class BcGroupClusterDetail : AopObject
    {
        /// <summary>
        /// 一个分组下会管理多个普通支付宝群，此参数表示如果分组下一个群人数已满，是否自动创建新群
        /// </summary>
        [XmlElement("auto_create_group")]
        public bool AutoCreateGroup { get; set; }

        /// <summary>
        /// 支付宝用户id；此分组的管理员id
        /// </summary>
        [XmlArray("cluster_admin_ids")]
        [XmlArrayItem("string")]
        public List<string> ClusterAdminIds { get; set; }

        /// <summary>
        /// 客户群分组id，此id唯一，分组下会管理一系列的客户群
        /// </summary>
        [XmlElement("cluster_id")]
        public string ClusterId { get; set; }

        /// <summary>
        /// 客群分组名称
        /// </summary>
        [XmlElement("cluster_name")]
        public string ClusterName { get; set; }

        /// <summary>
        /// 支付宝用户id；一个分组下会管理多个普通支付宝群，此id表示分组下创建普通支付宝群的管理员id
        /// </summary>
        [XmlArray("default_admin_ids")]
        [XmlArrayItem("string")]
        public List<string> DefaultAdminIds { get; set; }

        /// <summary>
        /// 一个分组下会管理多个普通支付宝群，此名称表示分组下创建普通支付宝群的名称
        /// </summary>
        [XmlElement("default_group_name")]
        public string DefaultGroupName { get; set; }

        /// <summary>
        /// 支付宝用户id；一个分组下会管理多个普通支付宝群，此id表示分组下创建普通支付宝群的群主id
        /// </summary>
        [XmlElement("default_master_id")]
        public string DefaultMasterId { get; set; }
    }
}
