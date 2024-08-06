# Exam Management System

## Overview
The Exam Management System is a Windows Forms Application designed for creating, editing, and taking exams. It allows users to manage exams and their questions, track progress, and calculate results efficiently.

## Features

### System Overview
- **Edit Exams**
- **Take Exam**

### Edit Exams

#### Creating a New Exam
1. **Enter the exam name.**
2. **Add questions with the following details:**
   - Description
   - Type (Yes/No, Multiple Choice, Multiple Answers)
   - Answer Options
   - Correct Answer
   - Score (Total score must be 100%)

#### Data Storage
- Exams and questions are saved as JSON files:
  - `exams.json`
  - `questions.json`
- Questions are saved with a draft status. Once finalized, the exam status changes to "Active".

#### Progress Tracking
- A progress bar updates to reflect the total score as questions are added.

### Editing an Exam

#### Exam List
- View and manage all exams, including drafts.
- Delete exams from the list.

#### Editing Process
- Access an exam to edit. It becomes a draft upon entry.
- Ensure the total score is 100%. The progress bar helps track this.

### Taking an Exam

#### Exam List
- Only exams with "Active" status are shown.

#### Exam Navigation
- Navigate through questions one at a time using "Next" and "Previous" buttons.
- Track the number of answered questions.

#### Completion
- The "Finish" button becomes available after the last question.
- A prompt appears if not all questions are answered, asking for confirmation to finish.

#### Result Calculation
- After finishing, the final score is displayed.
- Detailed feedback on incorrect answers is provided.

## Development Notes
- **Error Handling:** Implement comprehensive error handling throughout the application.
- **LINQ Queries:** Use LINQ for efficient data querying and manipulation.

## Installation

1. Clone the repository:
   ```bash
   git clone <repository-url>
