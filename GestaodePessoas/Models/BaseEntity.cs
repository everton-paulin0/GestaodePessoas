namespace GestaodePessoas.Models
{
    public class BaseEntity
    {
        
        public BaseEntity()
        {
            CreatedAt = DateTime.Now;
            UpdateAt = DateTime.Now;
            IsActive = true;
        }
        
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsActive { get; set; }

    }
}
