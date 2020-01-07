using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiServindustryExerciseMemberphoneSyncResponse.
    /// </summary>
    public class KoubeiServindustryExerciseMemberphoneSyncResponse : AopResponse
    {
        /// <summary>
        /// 健身用户手机号与健身用户id映射
        /// </summary>
        [XmlArray("mapping_list")]
        [XmlArrayItem("exercise_user_mapping_d_t_o")]
        public List<ExerciseUserMappingDTO> MappingList { get; set; }
    }
}
