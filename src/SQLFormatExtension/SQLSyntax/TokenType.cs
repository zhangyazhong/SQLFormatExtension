/*
    Copyright 2020 Yazhong Zhang

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
*/

namespace SQLFormatExtension
{
    public enum TokenType
    {
        Whitespace = 0,
        Word = 1,
        Quote = 2,
        BacktickQuote = 3,
        Reserved = 4,
        ReservedTopLevel = 5,
        ReservedNewline = 6,
        Boundary = 7,
        Comment = 8,
        BlockComment = 9,
        Number = 10,
        Error = 11,
        Variable = 12
    }
}