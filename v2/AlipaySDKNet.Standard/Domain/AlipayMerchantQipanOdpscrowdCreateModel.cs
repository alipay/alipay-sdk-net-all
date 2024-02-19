using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantQipanOdpscrowdCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantQipanOdpscrowdCreateModel : AopObject
    {
        /// <summary>
        /// 安全应用范围，参考文档 安全应用范围枚举 未传值或传入渠道均非法时 采用默认渠道，默认渠道：支付结果页AA、繁星激励。 传入值时，以商户入参为准。
        /// </summary>
        [XmlArray("apply_channel_list")]
        [XmlArrayItem("string")]
        public List<string> ApplyChannelList { get; set; }

        /// <summary>
        /// 支付宝人群描述
        /// </summary>
        [XmlElement("crowd_desc")]
        public string CrowdDesc { get; set; }

        /// <summary>
        /// 人群名称 最大长度为15个字符
        /// </summary>
        [XmlElement("crowd_name")]
        public string CrowdName { get; set; }

        /// <summary>
        /// 商户外部用户人群code 用于标识商家人群，需保证同一商户下crowd_code唯一
        /// </summary>
        [XmlElement("external_crowd_code")]
        public string ExternalCrowdCode { get; set; }

        /// <summary>
        /// 人群在支付宝棋盘站点是否可见,取值如下： true-支付宝站点不可见 false-支付宝站点可见，默认值 使用说明：创建的人群后续需使用标签进行二次圈选，且本人群对商户不可见时可设置为true。
        /// </summary>
        [XmlElement("hidden")]
        public bool Hidden { get; set; }

        /// <summary>
        /// 用户唯一标识列名
        /// </summary>
        [XmlElement("identify_column")]
        public string IdentifyColumn { get; set; }

        /// <summary>
        /// 离线表是否分区
        /// </summary>
        [XmlElement("is_partition")]
        public bool IsPartition { get; set; }

        /// <summary>
        /// 离线表分区字段
        /// </summary>
        [XmlElement("partition_column")]
        public string PartitionColumn { get; set; }

        /// <summary>
        /// 离线项目空间
        /// </summary>
        [XmlElement("project")]
        public string Project { get; set; }

        /// <summary>
        /// 更新周期 1. DO_NOT:不更新  2.DAY_N:每N天更新（N取值1,2,3,7,15,30,60,90,180,366）
        /// </summary>
        [XmlElement("refresh_period")]
        public string RefreshPeriod { get; set; }

        /// <summary>
        /// 数据源表名
        /// </summary>
        [XmlElement("table")]
        public string Table { get; set; }

        /// <summary>
        /// 过滤条件字段列表
        /// </summary>
        [XmlArray("where_columns")]
        [XmlArrayItem("string")]
        public List<string> WhereColumns { get; set; }

        /// <summary>
        /// 查询过滤条件
        /// </summary>
        [XmlElement("where_condition")]
        public string WhereCondition { get; set; }
    }
}
