using System;

namespace CodeBlogFitness.BL.Model
{
    /// <summary>
    /// Пол.
    /// </summary>
    [Serializable]
    public class Gender
    {
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Создать новый пол.
        /// </summary>
        /// <param name="name">Имя пола. </param>
        public Gender(string name)
        {
            if(string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола не можут быть пустым или Null", nameof(name));
            }
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
