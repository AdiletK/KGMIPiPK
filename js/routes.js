
const url = "https://localhost:44326/"

const routes = {

    getStudent: url + "api/student/",
    createStudent: url + "api/student/",
    updateStudent: url + "api/student/",
    deleteStudent: url + "api/student/",

    searchStudentByFIO: url + "api/student/search/",

    updateStudentPrisutstvie: url + "api/lextures/prisutstvie/",

    findCourseByGroupID: url + "api/course/",

    getGroupsByCourseID: url + "api/groups/",

    getDistricts: url + "api/districts/",

    getSettlements: url + "api/settlements/",

    getLpus: url + "api/lpus/",

    getStudentsByGroups: url + "api/groups/students/"

}


export default routes;