﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace AdamEntBot.Middleware.Telemetry
{
    /// <summary>
    /// The Application Insights property names that we're logging.
    /// </summary>
    public static class QnATelemetryConstants
    {
        public const string KnowledgeBaseIdProperty = "knowledgeBaseId";
        public const string AnswerProperty = "answer";
        public const string ArticleFoundProperty = "articleFound";
        public const string ChannelIdProperty = "channelId";
        public const string OriginalQuestionProperty = "originalQuestion";
        public const string QuestionProperty = "question";
        public const string QuestionIdProperty = "questionId";
        public const string ScoreProperty = "score";
        public const string UsernameProperty = "username";
    }
}