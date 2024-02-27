import {
    useParams,
} from 'react-router-dom';
import { Image } from 'antd';

function Profile() {
    const params = useParams();
    let id = params.profileId;
    return (
        <>
            <div>
                <Image
                    width={200}
                    src="https://zos.alipayobjects.com/rmsportal/jkjgkEfvpUPVyRjUImniVslZfWPnJuuZ.png" />
            </div>
            </>
    );

}

export default Profile;