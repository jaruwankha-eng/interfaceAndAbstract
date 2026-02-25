นางสาวจารุวรรณ เค้าเหลือง 683450184-0

# Training Registration System (C#)

ระบบรับสมัครฝึกอบรม ประกอบด้วย
- นักศึกษา
- อาจารย์
- บุคคลทั่วไป
- วิทยากร

## Features
- เพิ่มข้อมูลผู้เข้าอบรม
- เพิ่มข้อมูลวิทยากร
- แสดงรายชื่อผู้เข้าอบรม
- แสดงรายชื่อวิทยากร

## โครงสร้าง
TrainingRegistrationSystem/
│
├── Person.cs
├── ITrainable.cs
├── ITrainer.cs
├── Student.cs
├── Teacher.cs
├── GeneralPerson.cs
├── TrainingSystem.cs
├── Program.cs
└── README.md

## classDiagram

classDiagram
class Person {
    <<abstract>>
    -FirstName : string
    -LastName : string
    -Phone : string
    -Email : string
    +GetFullName() string
    +DisplayInfo() void
}

class ITrainable {
    <<interface>>
    +RegisterTraining() void
}

class ITrainer {
    <<interface>>
    +ConductTraining() void
    +ApproveResult() void
}

class Student {
    -StudentId : string
    -Major : string
    +RegisterTraining() void
    +DisplayInfo() void
}

class Teacher {
    -Major : string
    -AcademicPosition : string
    +RegisterTraining() void
    +ConductTraining() void
    +ApproveResult() void
    +DisplayInfo() void
}

class GeneralPerson {
    -Workplace : string
    -Position : string
    +RegisterTraining() void
    +ConductTraining() void
    +ApproveResult() void
    +DisplayInfo() void
}

class TrainingSystem {
    -Participants : List~Person~
    -Trainers : List~Person~
    +AddParticipant(Person p) void
    +AddTrainer(Person p) void
    +ShowParticipants() void
    +ShowTrainers() void
}

Person <|-- Student
Person <|-- Teacher
Person <|-- GeneralPerson

ITrainable <|.. Student
ITrainable <|.. Teacher
ITrainable <|.. GeneralPerson

ITrainer <|.. Teacher
ITrainer <|.. GeneralPerson
