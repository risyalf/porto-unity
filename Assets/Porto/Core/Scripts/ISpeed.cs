namespace Porto.Core.Scripts
{
    /// <summary>
    /// Untuk menggerakkan suatu object
    /// </summary>

    public interface ISpeed
    {
        /// <summary>
        /// Nilai kecepatan normal.
        /// </summary>
        float Value { get; }
        
        /// <summary>
        /// Nilai kecepatan dengan dorongan.
        /// </summary>
        float ValueBoost { get; }
    }
}