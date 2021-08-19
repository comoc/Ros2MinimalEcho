# Ros2MinimalEcho
Exchanging String messages between Unity and ROS2

## Modules used
- [ROS-TCP-Connector v.0.5.0](https://github.com/Unity-Technologies/ROS-TCP-Connector/tree/v0.5.0)
- [ROS-TCP-Endpoint 0c8537e](https://github.com/Unity-Technologies/ROS-TCP-Endpoint/tree/0c8537e4862b268062c9d5949366b192b6e1fee0)

For more information, please refer to [Robotics-Nav2-SLAM-Example](https://github.com/Unity-Technologies/Robotics-Nav2-SLAM-Example).

## Run

### Terminal 1: TCP-Endpoint
```$ ros2 launch ros_tcp_endpoint endopint.py```
### Terminal 2: Publish a topic to Unity
```$ ros2 topic pub /to_unity std_msgs/String "data: Hello"```

### Terminal 3: See the topic from Unity
```$ ros2 topic echo /from_unity```

### Unity
Open `Scenes/SampleScene`, then just press the Play button.
