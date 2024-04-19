using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceCcmServicerecordModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCcmServicerecordModifyModel : AopObject
    {
        /// <summary>
        /// 来电唯一标识
        /// </summary>
        [XmlElement("acid")]
        public string Acid { get; set; }

        /// <summary>
        /// 客服坐席号(软电话中定义的)
        /// </summary>
        [XmlElement("aid")]
        public string Aid { get; set; }

        /// <summary>
        /// 主叫号码
        /// </summary>
        [XmlElement("ani")]
        public string Ani { get; set; }

        /// <summary>
        /// 恒生专用来电唯一标识
        /// </summary>
        [XmlElement("asid")]
        public string Asid { get; set; }

        /// <summary>
        /// 类目信息(详细信息请参考具体类型描述)
        /// </summary>
        [XmlElement("category_list")]
        public ServiceRecordCatRequest CategoryList { get; set; }

        /// <summary>
        /// 标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("chat_begin_time")]
        public string ChatBeginTime { get; set; }

        /// <summary>
        /// 标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("chat_end_time")]
        public string ChatEndTime { get; set; }

        /// <summary>
        /// 来电地址
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 创建者ID
        /// </summary>
        [XmlElement("creator_id")]
        public string CreatorId { get; set; }

        /// <summary>
        /// 先挂断方 AGENT:客服 CUSTOMER:客户
        /// </summary>
        [XmlElement("discon_symbol")]
        public string DisconSymbol { get; set; }

        /// <summary>
        /// 被叫号码
        /// </summary>
        [XmlElement("dnis")]
        public string Dnis { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        [XmlElement("file_size")]
        public long FileSize { get; set; }

        /// <summary>
        /// 创建时间(yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 云客服服务记录ID
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 服务记录备注信息
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 修改人ID
        /// </summary>
        [XmlElement("modifier_id")]
        public string ModifierId { get; set; }

        /// <summary>
        /// 外呼任务ID
        /// </summary>
        [XmlElement("outbound_task_id")]
        public string OutboundTaskId { get; set; }

        /// <summary>
        /// 满意度 0:非常满意 1:满意 2:一般 3:不满意 4:非常不满意
        /// </summary>
        [XmlElement("satisfaction")]
        public string Satisfaction { get; set; }

        /// <summary>
        /// 满意度补充信息
        /// </summary>
        [XmlElement("satisfaction_memo")]
        public string SatisfactionMemo { get; set; }

        /// <summary>
        /// 1:客户来电 4:电话回访 5:网点服务 6:在线服务 7:外呼任务 8:手动外呼 9:在线离线留言
        /// </summary>
        [XmlElement("service_source")]
        public string ServiceSource { get; set; }

        /// <summary>
        /// 服务时长(单位:秒)
        /// </summary>
        [XmlElement("service_time")]
        public long ServiceTime { get; set; }

        /// <summary>
        /// 技能组ID
        /// </summary>
        [XmlElement("skillgroup_id")]
        public string SkillgroupId { get; set; }

        /// <summary>
        /// 技能组名称(技能组ID对应的技能组名称)
        /// </summary>
        [XmlElement("skillgroup_name")]
        public string SkillgroupName { get; set; }

        /// <summary>
        /// 1:待处理 2:暂存 3:完结 4:废除 5:无效 6:未知
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 业务租户
        /// </summary>
        [XmlElement("tnt_inst_id")]
        public string TntInstId { get; set; }

        /// <summary>
        /// 来访用户唯一标识ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// IVR验证结果 ROLE_N:未定位到用户 CERTNO_Y_PWD_Y:证件号码+交易密码验证通过 CERTNO_Y_PWD_N:证件号码验证通过+交易密码不通过 CERTNO_Y_PWD_UNKNOW:证件号码验证通过 PHONE_Y_PWD_Y:来电手机+交易密码验证通过 PHONE_Y_PWD_N:来电手机+交易密码未通过 PHONE_Y_PWD_UNKNOW:来电手机账户 SEARCH_Y_PWD_Y:搜索定位用户+推屏交易密码通过 SEARCH_Y_PWD_N:搜索定位用户+推屏交易密码未通过 SEARCH_Y_PWD_UNKNOW:搜索定位用户
        /// </summary>
        [XmlElement("verify_result")]
        public string VerifyResult { get; set; }
    }
}
