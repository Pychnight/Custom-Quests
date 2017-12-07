﻿namespace CustomQuests.Quests
{
    /// <summary>
    ///     Represents information about a quest.
    /// </summary>
    public sealed class QuestInfo
    {
        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets the friendly name.
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        ///     Gets or sets the Lua path.
        /// </summary>
        public string LuaPath { get; set; }

        /// <summary>
        ///     Gets or sets the maximum number of parties that can concurrently do the quest.
        /// </summary>
        public int MaxConcurrentParties { get; set; }

        /// <summary>
        ///     Gets or sets the maximum party size.
        /// </summary>
        public int MaxPartySize { get; set; }

        /// <summary>
        ///     Gets or sets the maximum number of repeats.
        /// </summary>
        public int MaxRepeats { get; set; }

        /// <summary>
        ///     Gets or sets the minimum party size.
        /// </summary>
        public int MinPartySize { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the required region name.
        /// </summary>
        public string RequiredRegionName { get; set; }
    }
}