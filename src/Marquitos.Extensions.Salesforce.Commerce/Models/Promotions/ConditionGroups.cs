namespace Marquitos.Salesforce.Commerce.Models.Promotions
{
    /// <summary>
    /// Represents a collection of condition groups for promotions.
    /// </summary>
    public class ConditionGroups : List<ConditionGroup>
    {
        /// <summary>
        /// Creates a new instance of <see cref="ConditionGroups"/> with an empty list of condition groups.
        /// </summary>
        public ConditionGroups() 
        { }

        /// <summary>
        /// Creates a new instance of <see cref="ConditionGroups"/> with the specified condition groups.
        /// </summary>
        /// <param name="conditionGroups"></param>
        public ConditionGroups(IEnumerable<ConditionGroup> conditionGroups) : base(conditionGroups)
        {
        }

        /// <summary>
        /// Creates a new instance of <see cref="ConditionGroups"/> with the specified condition groups.
        /// </summary>
        /// <param name="conditionGroups"></param>
        public ConditionGroups(params ConditionGroup[] conditionGroups) : base(conditionGroups)
        {
        }
    }
}
