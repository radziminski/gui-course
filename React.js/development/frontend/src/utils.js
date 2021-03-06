const MONTH_NAMES = [
    'January',
    'February',
    'March',
    'April',
    'May',
    'June',
    'July',
    'August',
    'September',
    'October',
    'November',
    'December',
];

export const getMonthStringFromDate = (date) => {
    return MONTH_NAMES[date.getMonth()];
};

export const dateToString = (date) =>
    `${date.getDate()} ${getMonthStringFromDate(date)} ${date.getFullYear()}`;

export const addDaysToDate = (date, daysAmount) => {
    date.setDate(date.getDate() + daysAmount);
};

export const digitToTwoCharString = (time) => {
    let timeString = time.toString();
    if (timeString.length === 1) return '0' + timeString;
    return timeString;
};

export const compareDates = (dateA, dateB) => {
    if (
        dateA.getDate() !== dateB.getDate() ||
        dateA.getMonth() !== dateB.getMonth() ||
        dateA.getFullYear() !== dateB.getFullYear()
    )
        return false;
    return true;
};
