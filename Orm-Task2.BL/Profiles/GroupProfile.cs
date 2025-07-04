using Orm_Task2.BL.Dtos.GroupDto;

namespace Orm_Task2.BL.Profiles;

public class GroupProfile
{
   public static Group GroupCreateToGroup(GroupCreateDto groupdto)
   {
      return new Group
      {
         No = groupdto.No,
        Limit = groupdto.Limit,
      };
   }

   public static GroupCreateDto GroupCreateToGroupDto(Group group)
   {
      return new GroupCreateDto
      {
         No = group.No,
         Limit = group.Limit,
      };
   }
}