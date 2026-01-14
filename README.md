# Attribute-Based Person Re-Identification using Unity Synthetic Data

## Overview
This project investigates attribute-based person re-identification (Re-ID) models and improves performance by generating labeled synthetic datasets using the Unity game engine.

## Environment
- Unity Editor: 2022.3 LTS
- Render Pipeline: URP
- Unity Perception Package: 0.9.0-preview.2
- OS: Windows 11
- GPU: Intel Iris Xe

## Project Structure
### Directory Tree

```text
attribute-based-reid-unity/
├── README.md
├── paper/
│   └─ individual_report.pdf           # 프로젝트 상세 보고서 및 연구 논문
├── screenshots/                       # 프로젝트 시각 자료
│   ├─ scene_overview.png              # 전체 유니티 씬 구성
│   ├─ labeling_example.png            # 데이터 라벨링 예시
│   ├─ randomization_rotation.png      # 회전 랜덤화 적용 예시
│   ├─ randomization_clothing_color.png # 의상 색상 랜덤화 예시
│   └─ synthetic_output_example.png    # 최종 생성된 합성 데이터 샘플
└── unity_project/                     # 유니티 프로젝트 소스
    ├── Assets/
    │   └─ Scripts/                    # 데이터 생성 및 랜덤화 제어 스크립트
    │      ├─ RotationRandomizer.cs     # 캐릭터 회전 값 랜덤 제어
    │      ├─ ShirtColorRandomizer.cs   # 상의 색상 랜덤 변경
    │      ├─ PantsColorRandomizer.cs   # 하의 색상 랜덤 변경
    │      └─ HatToggleRandomizer.cs    # 모자 착용 여부 랜덤 활성화
    ├── Packages/                      # 유니티 패키지 의존성 관리
    └─ ProjectSettings/                # 프로젝트 전역 설정 파일
```



## Dataset Generation
- Perception Camera
- Automatic labeling (clothing color, accessories, etc.)
- Randomization (rotation, color, accessory toggle)

## How to Run
1. Open the project in Unity Hub
2. Load the sample scene
3. Press Play to generate synthetic images

## Features
- Shirt color randomization
- Pants color randomization
- Hat on/off randomization
- Character rotation randomization

## Notes
Due to storage constraints, full datasets are not included.
