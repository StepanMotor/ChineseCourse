//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChineseCourse.Model1
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.UserAndTask = new HashSet<UserAndTask>();
        }
    
        public int id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public Nullable<int> Level { get; set; }
        public string Photo { get; set; }
        public int Role { get; set; }
    
        public virtual Role Role1 { get; set; }
        public virtual ICollection<UserAndTask> UserAndTask { get; set; }
    }
}
