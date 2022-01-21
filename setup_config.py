import os


def main():
    app_secret = os.environ.get('APPCENTER_SECRET', '')
    file_name = "Notes-Desktop/AppConfig.cs"
    lines = []
    with open(file_name, "r") as file:
        for line in file:
            line = line.replace('<%APPCENTER_SECRET%>', app_secret)
            lines.append(line)
    with open(file_name, "w") as file:
        file.write('\n'.join(lines))


if __name__ == "__main__":
    main()
